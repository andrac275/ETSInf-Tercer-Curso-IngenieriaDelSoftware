console.log()
const siguiente = x => x+1
const anterior = x => x-1
const doble     = x => x*2
const mitad    = x => x/2
const compose = (a,b) => c => a(b(c))
console.log(a.map(compose(doble,anterior)))
console.log(a.map(compose(mitad,siguiente)))

console.log()

function sumScan(a){
    let b=[]
    let acumulador = 0
    for(i=0; i<a.length; i++){ //cada elem de a
        acumulador=a[i]+acumulador
        b.push(acumulador)
    }
    return b
}

function prdScan(a){
    let b=[]
    let acumulador = a[0]
    b[0]= a[0]
    for(i=1; i<a.length; i++){ //cada elem de a
        acumulador=a[i]*acumulador
        b.push(acumulador)
    }
    return b
}

function maxScan(a){
    let b=[]
    let max = a[0]
    b[0]= a[0]
    for(i=1; i<a.length; i++){ //cada elem de a
        if(a[i] > max)
            max = a[i]

        b.push(max)
    }
    return b
}

function minScan(a){
    let b=[]
    let min = a[0]
    b[0]= a[0]
    for(i=1; i<a.length; i++){ //cada elem de a
        if(a[i] < min)
            min = a[i]
            
        b.push(min)
    }
    return b
}

let v=[2,3,4,1]
console.log("SumScan: "+ sumScan(v))
console.log("PrdScan: "+ prdScan(v))
console.log("MaxScan: "+ maxScan(v))
console.log("MinScan: "+ minScan(v))