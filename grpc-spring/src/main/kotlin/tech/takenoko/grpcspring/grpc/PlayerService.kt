package tech.takenoko.grpcspring.grpc

import kotlinx.coroutines.ExperimentalCoroutinesApi
import kotlinx.coroutines.delay
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.channelFlow
import org.lognet.springboot.grpc.GRpcService
import tech.takenoko.grpcspring.model.toVector
import tech.takenoko.grpcspring.model.toVector3_
import tech.takenoko.grpcspring.proto.PlayerGrpcKt
import tech.takenoko.grpcspring.proto.PlayerOuterClass.*
import tech.takenoko.grpcspring.repository.PlayerRepository
import tech.takenoko.grpcspring.utils.MessageInterceptor

/**
 * grpcurl -plaintext -d '{"uuid": "1"}' localhost:6565 tech.takenoko.grpcspring.proto.Player/Move
 * grpcurl -plaintext -d '{"uuid": "1", "position": {"x": 100, "y":100, "z": 100}}' localhost:6565 tech.takenoko.grpcspring.proto.Player/Move
 */
@ExperimentalCoroutinesApi
@GRpcService(interceptors = [MessageInterceptor::class])
class PlayerService(private val playerRepository: PlayerRepository): PlayerGrpcKt.PlayerCoroutineImplBase() {
    override suspend fun move(request: MoveRequest): MoveReply {
        val uuid = request.uuid
        val position = request.position.toVector()
        val rotation = request.rotation.toVector()
        // val hp = request.status.hp
        // val mp = request.status.mp

        try {
            playerRepository.change(uuid, position, rotation)
        } catch(e: Exception) {
            println(e)
        }

        return MoveReply.newBuilder().build()
    }

    override fun changed(request: ChangedRequest): Flow<ChangedReply> = channelFlow {
        val uuid = request.uuid
        playerRepository.addObserver(uuid, object: PlayerRepository.PlayerObserver {
            override suspend fun update(player: PlayerRepository.PlayerModel?) {
                if(player == null) return
                val reply = ChangedReply.newBuilder().apply {
                    position = player.position.toVector3_()
                    rotation = player.rotation.toVector3_()
                }
                runCatching {
                    this@channelFlow.channel.send(reply.build())
                }.onFailure {
                    playerRepository.removeObserver(uuid, this)
                }
            }
        })
        delay(100000000)
    }
}