const zmq = require('zeromq')
let req = zmq.socket('req');
req.connect(process.argv[2])
req.on('message', (msg)=> {
	console.log('He rebut un missatge de resposta de broker1')
	console.log('resp: '+msg)
	process.exit(0);
})
console.log('Envie un missatge a broker 1')
req.send(process.argv[3])
