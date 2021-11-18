const zmq = require('zeromq')
let cli=[], req=[], workers=[]
let sc = zmq.socket('router') // frontend
let sw = zmq.socket('router') // backend
let contador = 0
let std={}
sc.bind('tcp://*:'+ process.argv[2])
sw.bind('tcp://*:'+ process.argv[3])
sc.on('message',(c,sep,m)=> {
	if (workers.length==0) { 
		cli.push(c); req.push(m)
	} else {
		sw.send([workers.shift(),'',c,'',m])
	}
})
sw.on('message',(w,sep,c,sep2,r)=> {
    if (c=='') { //Este if es per al primer missatge del worker
		workers.push(w);
		std[w]=0; //Possar a 0 el contador de missatges enviats del worker 0.
		return
	}else{//si no es el primer missatge
		std[w]++; //Augmentar els missatges enviats per eixe worker
	}
	if (cli.length>0) { 
		sw.send([w,'',
			cli.shift(),'',req.shift()])
	} else {
		workers.push(w)
	}
	sc.send([c,'',r + " contador es: "+ ++contador])
})

//Cada 5 segons mostra per pantalla lo de dump
setInterval(dump,5000);

function dump(){
	//Recorre tots els valor del vectos std que te el numero de missatges enviats per cada worker.
	for(let k in std){
		console.log("El worker " + k + " ha enviat " +std[k] + "missatges")
	}
}
