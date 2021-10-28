const zmq = require('zeromq')
let sub = zmq.socket('sub')
sub.subscribe('')   //Deixar la tira buida es per a que arribe tot.
sub.connect('tcp://127.0.0.1:9999')
sub.on('message', (m) =>{
    console.log(JSON.parse(m))
})