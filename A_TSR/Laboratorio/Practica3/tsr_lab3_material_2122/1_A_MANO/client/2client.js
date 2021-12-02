const zmq = require('zeromq')
let req = zmq.socket('req');
let respostes = 10
let respostesRebudes = 0
var args = process.argv.slice(2)
if (args.length < 1) {
  console.log ("node myclient brokerURL")
  process.exit(-1)
}
req.connect(args[0])
var bkURL   = args[0]
console.log(bkURL)
req.connect(bkURL)
req.on('message', (msg)=> {
	respostesRebudes++
	console.log('resp: '+msg)
	if (respostesRebudes == respostes){
		console.log('Acabe jo ja...')
		process.exit(0);
	}
})

for (let i = 0; i <respostes;i++){
	req.send('Hola')
	}
