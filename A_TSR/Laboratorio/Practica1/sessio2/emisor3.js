//Emisor de eventos (emisor3.js) -------------------------------------------
const ev = require('events')
const emitter=new ev.EventEmitter()

const e1='e1', e2='e2'
let inc=0, t

function rand() { // debe devolver valores aleat en rango [2000,5000) (ms)
    numero = Math.random() * 3000 + 2000   // Math.random() devuelve un valor en el rango [0,1)
    return Math.floor(numero)     // Math.floor(x) devuelve la parte entera del valor x
}

function handler (e,n) { // e es el evento, n el valor asociado
    return (inc) => {// el oyente recibe un valor (inc)      
        n+=inc
        console.log(e+'-->'+n)                
    } 
}

emitter.on(e1, handler(e1,0))
emitter.on(e2, handler(e2,''))

function etapa() {
        emitter.emit(e1,inc)
        emitter.emit(e2,inc)
        inc++
        console.log('duracion: ' + t)
        
        setTimeout(etapa,t=rand())  
}

setTimeout(etapa,t=rand())