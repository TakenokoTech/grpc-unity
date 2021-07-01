package tech.takenoko.grpcspring.model

data class Vector3(val x: Float, val y: Float, val z: Float)

fun tech.takenoko.grpcspring.proto.Common.Vector3_.toVector() = Vector3(x, y, z)
fun Vector3.toVector3_() = tech.takenoko.grpcspring.proto.Common.Vector3_.newBuilder().setX(x).setY(y).setZ(z).build()