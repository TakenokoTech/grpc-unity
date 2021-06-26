import com.google.protobuf.gradle.*
import org.jetbrains.kotlin.gradle.tasks.KotlinCompile

plugins {
	id("org.springframework.boot") version "2.5.2"
	id("io.spring.dependency-management") version "1.0.11.RELEASE"
	kotlin("jvm") version "1.5.20"
	kotlin("plugin.spring") version "1.5.20"
	id("com.google.protobuf") version "0.8.16"
}

group = "tech.takenoko"
version = "0.0.1-SNAPSHOT"
java.sourceCompatibility = JavaVersion.VERSION_1_8

configurations {
	compileOnly {
		extendsFrom(configurations.annotationProcessor.get())
	}
}

repositories {
	mavenCentral()
}

dependencies {
	// kotlin
	implementation("org.jetbrains.kotlin:kotlin-stdlib-jdk8")
	implementation("org.jetbrains.kotlin:kotlin-reflect")
	implementation("com.fasterxml.jackson.module:jackson-module-kotlin")

	// spring
	implementation("org.springframework.boot:spring-boot-starter-web")
	developmentOnly("org.springframework.boot:spring-boot-devtools")
	annotationProcessor("org.springframework.boot:spring-boot-configuration-processor")
	testImplementation("org.springframework.boot:spring-boot-starter-test")

	// grpc
	implementation("com.google.protobuf:protobuf-java:3.17.3")
	implementation("io.grpc:grpc-stub:1.38.1")
	implementation("io.grpc:grpc-protobuf:1.38.1")
	implementation("io.github.lognet:grpc-spring-boot-starter:4.5.4")
}

tasks.withType<KotlinCompile> {
	kotlinOptions {
		freeCompilerArgs = listOf("-Xjsr305=strict")
		jvmTarget = "1.8"
	}
}

tasks.withType<Test> {
	useJUnitPlatform()
}

sourceSets {
	main {
		java {
			srcDirs("build/generated/source/proto/main/grpc")
			srcDirs("build/generated/source/proto/main/java")
		}
	}
}

protobuf {
	// generatedFilesBaseDir = "$projectDir/src/"
	protoc { artifact = "com.google.protobuf:protoc:3.17.3" }
	plugins { id("grpc") { artifact = "io.grpc:protoc-gen-grpc-java:1.38.1" } }
	generateProtoTasks { ofSourceSet("main").forEach { it.plugins { id("grpc") } } }
}
