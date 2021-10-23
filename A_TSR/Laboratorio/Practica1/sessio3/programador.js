//Modificat Andreu
const net = require('net');

const argumentos=process.argv.slice(2);

const client = net.connect({port:8001,host:argumentos[0]}, 
    function() { //connect listener
        console.log('PROGRAMADOR connected');
        var missatge =JSON.stringify([argumentos[1],argumentos[2]])
        client.write(missatge);
    });

client.on('data', 
    function(data) {
        console.log(data.toString());
        client.end(); //no more data written to the stream
    });

client.on('end', 
    function() {
        console.log('programador disconnected');
    });

