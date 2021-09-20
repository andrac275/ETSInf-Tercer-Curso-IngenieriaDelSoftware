//Pruebas de coercion. 33/97
console.log(Number(true))
console.log(Number(false))
console.log(Number("10"))
console.log(Number("       10"))
console.log(Number("10    20"))
console.log(Number("Andreu"))
console.log(String(15.556))
console.log(String(true))
console.log(parseInt("10.55"))
console.log(parseInt("14 years"))
console.log(parseFloat("10"))
console.log(parseFloat("40.33"))

console.log()
console.log(Boolean("false"))   //devuelve true
console.log(Boolean(""))    //devuelve false
let variableNaN = 0/0
console.log(variableNaN)
console.log(Boolean(variableNaN))   //la variable NaN torna false
console.log(Boolean(undefined))     //torna false
console.log(Boolean("undefined"))   //torna true

console.log()
console.log("Ejemplos de comparador normal ==")
console.log(null == undefined)
console.log(null == 0)
console.log("5" == 5)
console.log(NaN == NaN)
console.log("Ejemplos de comparador estricto ===")
console.log(null === undefined)
console.log("5" === 5)
console.log(NaN === NaN)

// diapos 36 de 97
console.log("Diapos 36")
let user = ""
console.log(user)
if (user)
    console.log("La variable user no esta vacia y es: " + user)
    else console.log("User esta vacio")

let person =0
console.log(person)
if (person)
    console.log("person existe y no es undefined y es: " + person)
    else console.log("person no esta definido")

console.log()
console.log("Obligar a que un cero no se considere vacio. PAsarlo a String primero en la guarda")
person = 0
console.log(person)
if (String(person))
    console.log("person existe y no es undefined y es: " + person)
    else console.log("person no esta definido")

console.log()
// o tambien.... con la comparacion estricta
let person2 = NaN
console.log(person2)
if(person2|| person2 ===0 || person2 ==="")
    console.log("Person exists. Esta definida y puede ser cero o vacio")
// o tambien sin coercion de tipos
let persona3 = 0
console.log(persona3)
if(persona3 !== null && persona3 !== undefined)
    console.log("persona3 esta definida")
