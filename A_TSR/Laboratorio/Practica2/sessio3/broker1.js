const zmq = require('zeromq')
let cli=[], req=[]
let workDisponible = 0
let sc = zmq.socket('router') // frontend
let b2 = zmq.socket('dealer') // backed. Broker 2
sc.bind('tcp://*:'+ process.argv[2])
b2.connect('tcp://localhost:' + process.argv[3])
sc.on('message',(c,sep,m)=> {
	if (workDisponible==0) { 
        console.log("Worker no disponible")
		cli.push(c); req.push(m)
	} else {
        console.log("Worker disponible, pasando peticion")
        workDisponible--
		b2.send([c,'',m])
	}
})
b2.on('message',(w,sep,c,sep1,r)=> {
    workDisponible++
    if (cli.length>0) { //Enviar mes feina si hi ha en la cola
        console.log("Enviar mes feina a un worker")
        workDisponible--
        b2.send([cli.shift(),'',req.shift()])
    } 
		
	if (c!='') {//Si distint cadena buida es que era una resposta
        console.log("El contingut de c es: " + c)
        console.log("Retornant missatge al client amb contingut " + r)
        //sc.send([c,'',r])
        sc.send([w,'',c])
    } 
})
