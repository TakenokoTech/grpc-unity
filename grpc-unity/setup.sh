protoc -I ../grpc-spring/src/main/proto \
--csharp_out=Assets/Grpc \
--grpc_out=Assets/Grpc \
--plugin=protoc-gen-grpc=/usr/local/bin/grpc_csharp_plugin \
common.proto

protoc -I ../grpc-spring/src/main/proto \
--csharp_out=Assets/Grpc \
--grpc_out=Assets/Grpc \
--plugin=protoc-gen-grpc=/usr/local/bin/grpc_csharp_plugin \
player.proto