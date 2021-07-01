package tech.takenoko.grpcspring.utils

import io.grpc.ServerCall
import io.grpc.ServerCallHandler
import io.grpc.ServerInterceptor
import org.slf4j.LoggerFactory


class MessageInterceptor: ServerInterceptor {
    companion object{
        private val log = LoggerFactory.getLogger(this::class.java)
    }

    override fun <P : Any?, R : Any?> interceptCall(call: ServerCall<P, R>?, headers: io.grpc.Metadata?, next: ServerCallHandler<P, R>): ServerCall.Listener<P> {
        log.info("method name:${call?.methodDescriptor?.fullMethodName}")
        return next.startCall(call, headers)
    }
}