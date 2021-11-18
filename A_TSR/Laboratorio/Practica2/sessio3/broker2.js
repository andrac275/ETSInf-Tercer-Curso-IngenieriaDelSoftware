const zmq = require('zeromq')
let workers=[]
let b1 = zmq.socket('dealer') // frontend. Broker 1
let sw = zmq.socket('router') // backend
b1.bind('tcp://*:'+ process.argv[2],(error)=>{
    if (error){console.log(error)}else{console.log("brok2 connectat amb brok1")}
})
sw.bind('tcp://*:'+ process.argv[3])
b1.on('message',(c,sep,m)=> {
    console.log("Passant missatge rebut de b1 al worker")
    sw.send([workers.shift(),'',c,'',m])
})

sw.on('message',(w,sep,c,sep1,r)=> {
    console.log("Passant missatge del worker a b1 amb contingut " + r)
    workers.push(w)
    b1.send([c,'',r])
})
