package tech.takenoko.grpcspring.repository

import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.flow.flow
import kotlinx.coroutines.withContext
import org.springframework.stereotype.Repository
import tech.takenoko.grpcspring.model.Vector3
import java.util.*


@Repository
class PlayerRepository {
    companion object {
        private val state = mutableMapOf<String, PlayerModel>()
        private val observers = mutableMapOf<String, MutableList<PlayerObserver>>()
    }

    suspend fun change(uuid: String, position: Vector3, rotation: Vector3) {
        state[uuid] = PlayerModel(position, rotation)
        withContext(Dispatchers.IO) {
            observers[uuid]?.forEach { it.update(state[uuid]) }
        }
    }

    suspend fun addObserver(uuid: String, o: PlayerObserver) {
        observers[uuid] = observers.getOrDefault(uuid, mutableListOf())
        observers[uuid]?.add(o)
    }

    suspend fun removeObserver(uuid: String, o: PlayerObserver) {
        observers[uuid]?.remove(o)
    }

    data class PlayerModel(val position: Vector3, val rotation: Vector3)

    interface PlayerObserver {
        suspend fun update(player: PlayerModel?)
    }
}