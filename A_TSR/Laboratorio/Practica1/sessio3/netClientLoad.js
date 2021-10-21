//Modificat Andreu
const net = require('net');

const argumentos=process.argv.slice(2);

const client = net.connect({port:8000,host:argumentos[0]}, 
    function() { //connect listener
        console.log('client connected');
        client.write(argumentos[1]);
    });

client.on('data', 
    function(data) {
        console.log(data.toString());
        client.end(); //no more data written to the stream
    });

client.on('end', 
    function() {
        console.log('client disconnected');
    });

