const zmq = require('zeromq')
let req = zmq.socket('req');
req.connect(process.argv[2])
req.on('message', (msg)=> {
	console.log('resp: '+msg)
	process.exit(0);
})
req.send(process.argv[3])
