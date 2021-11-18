const zmq = require('zeromq')
let req = zmq.socket('req')
req.identity=process.argv[3]
req.connect(process.argv[2])
req.on('message', (c,sep,msg)=> {
	console.log("Soc el worker i he rebut un missatge del broker2: " + msg)
	setTimeout(()=> {
		req.send([c,'',process.argv[4]])
	}, 1000)
})
req.send(['','',''])
