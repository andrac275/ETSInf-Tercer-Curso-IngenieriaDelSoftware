// proxyConf.js ------------------------------------------------------------
//Modificat Andreu
const net = require('net');
const argumentos = process.argv.slice(2);

const LOCAL_PORT  = 8000;
const LOCAL_IP  = '127.0.0.1';
const REMOTE_PORT = argumentos[1]
const REMOTE_IP = argumentos[0]; // www.upv.es

const server = net.createServer(function (socket) {
      const serviceSocket = new net.Socket();
      serviceSocket.connect(parseInt(REMOTE_PORT),   
         REMOTE_IP, function () {
          socket.on('data', function (msg) {
               serviceSocket.write(msg);
          });
          serviceSocket.on('data', function (data) {
             socket.write(data);
          });
      });
}).listen(LOCAL_PORT, LOCAL_IP);
console.log("TCP server accepting connection on port: " + LOCAL_PORT);


//Part per a que el prgramador cambie la ip i els ports
const server2 = net.createServer( 
   function(c) { //connection listener
       console.log('server: Programador connected');
       c.on('end', 
           function() {
               console.log('server: Programador disconnected');
           });
       c.on('data', 
           function(missatge) {        
                let contingut=JSON.parse(missatge);
                console.log(contingut);
                let REMOTE_IP_NUEVA=contingut[0];
                let REMOTE_PORT_NUEVA=contingut[1];
                 c.write('IP i ports cambiats a: ' +contingut[0]+":"+contingut[1]); // send resp
                
                server.close();

                const server = net.createServer(function (socket) {
                    const serviceSocket = new net.Socket();
                    serviceSocket.connect(parseInt(REMOTE_PORT_NUEVA),   
                       REMOTE_IP_NUEVA, function () {
                        socket.on('data', function (msg) {
                             serviceSocket.write(msg);
                        });
                        serviceSocket.on('data', function (data) {
                           socket.write(data);
                        });
                    });
              }).listen(LOCAL_PORT, LOCAL_IP);
              console.log("TCP server accepting connection on port: " + LOCAL_PORT + " redireccionando a nuevo servidor.");

                 c.end(); // close socket
           });
   });

server2.listen(8001,
   function() { //listening listener
       console.log("TCP server accepting connection on port: 8001"); 
   });
   