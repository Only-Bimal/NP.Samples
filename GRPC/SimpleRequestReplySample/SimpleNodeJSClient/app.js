module;

let grpc = require('@grpc/grpc-js');
let protoLoader = require('@grpc/proto-loader');

const protobuf = require('protobufjs');

const root = protoLoader.loadSync('../interfaces/service.proto', { keepCase: true, longs: String, enums: String, defaults: true, oneofs: true });

const greet = grpc.loadPackageDefinition(root).greet;

const client = new greet.Greeter("localhost:5555", grpc.credentials.createInsecure());

client.sayHello({ name: "Joe Doe" }, function (err, response) {
    console.log(response.msg);
});
