const zmq = require('zeromq')
let pub = zmq.socket('pub')
const argumentos=process.argv.slice(2)
let port = argumentos[0]
let maxMessages = argumentos[1]
let contador = 0

let temes= []
for(let i=2; i< argumentos.length; i++){
    temes.push(argumentos[i])   //Rellenar array amb els temes.
}


pub.bind('tcp://*:'+port) 
function emite(){    
    let numero = 1+ Math.floor(contador / temes.length)
    //Rotar el array. Enviar el element 0 i encuarlo al final
    let m = temes[0]    //Guardar primer element
    pub.send(JSON.stringify(m + ' ' + numero)) //Enviar element junt a numero
    temes.shift()   //Treure primer element
    temes.push(m)   //Encuarlo

    //Augmentar contador
    contador++

}
setInterval(emite,1000) //Envia cada segon
setTimeout(()=>{process.exit()},maxMessages*1000) //talla una volta han passat els segons = numMenssatges