//Modificat Andreu
const net = require('net');
const fs =require('fs');

const server = net.createServer( 
    function(c) { //connection listener
        console.log('server: client connected');
        c.on('end', 
            function() {
                console.log('server: client disconnected');
            });
        c.on('data', 
            function(missatge) {
                let carga=getLoad();
                let ipServer="172.23.2.242";
                c.write("Soy el servidor Andrac, mi IP es: " + ipServer + " y mi carga es: "+carga); // send resp
                  c.end(); // close socket
            });
    });

server.listen(8000,
    function() { //listening listener
        console.log('server bound'); 
    });
	
// función getLoad -----------------------------------------------------
function getLoad(){
  data=fs.readFileSync("/proc/loadavg"); //requiere fs
  var tokens = data.toString().split(' ');
  var min1  = parseFloat(tokens[0])+0.01;
  var min5  = parseFloat(tokens[1])+0.01;
  var min15 = parseFloat(tokens[2])+0.01;
  return min1*10+min5*2+min15;
};