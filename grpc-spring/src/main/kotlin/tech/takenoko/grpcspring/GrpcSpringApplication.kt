package tech.takenoko.grpcspring

import org.springframework.boot.autoconfigure.SpringBootApplication
import org.springframework.boot.runApplication

@SpringBootApplication
class GrpcSpringApplication

/**
 * $grpcurl -plaintext localhost:6565 list
 */
fun main(args: Array<String>) {
	runApplication<GrpcSpringApplication>(*args)
}
