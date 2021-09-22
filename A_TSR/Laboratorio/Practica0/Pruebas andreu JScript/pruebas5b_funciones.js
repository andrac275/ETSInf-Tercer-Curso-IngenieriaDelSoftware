//61 de 97
function product(a , b){
    return a * b;
}

function add(a , b){
    return a + b;
}

function subtract(a , b){
    return a - b;
}

let operacionsAritmetiques = [product, add, subtract]
console.log("Producte: " +operacionsAritmetiques[0](2,3))
console.log("Suma: " +operacionsAritmetiques[1](2,3))
console.log("Resta: " +operacionsAritmetiques[2](2,3))

//62 de 97
//Funcions anonimes. Lo mateix que abans, pero anonim.
console.log("Funcions anonimes")
let operacionsAritmetiques2 =[
    function(a , b){return a * b;},
    function(a , b){return a + b;},
    function(a , b){return a - b;}
    ]
console.log("Producte: " +operacionsAritmetiques2[0](2,3))
console.log("Suma: " +operacionsAritmetiques2[1](2,3))
console.log("Resta: " +operacionsAritmetiques2[2](2,3))

//63 de 97
//Funcions anonimes. Altre exemple
console.log("Altre exemple de funcio anonima")
function computeTable(n,fn){
    for(let i=1; i <=10;i++){
        fn(n * i)
    }
}
computeTable(2,function(v){console.log(v)})

//64 de 97
