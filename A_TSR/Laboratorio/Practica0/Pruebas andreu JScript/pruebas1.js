let x = 6
console.log(x)
x = "Hello"
console.log(x)

console.log()
console.log("Ejemplos de tipificacion debil")
console.log(8*null)
console.log("5" - 1)
console.log("5" + 1)
console.log("five" * 2)
console.log("5"*"2")
console.log(5+[1,2,3])

console.log()
console.log("Variable undefined")
let variableVacia     //variableVacia se puede dejar sin poner un valor o añadirle uno
        //para que entre por un if o el else.
console.log(variableVacia)
if (typeof variableVacia != "undefined")
    console.log("La variable tiene por valor: " + variableVacia)
    else console.log("La variable no estaba definida")

console.log()
x = 0.2
let y = 0.29999999999999999999999999999999
console.log(x+y)    //dona 0.5 perque redondeja, pero duria ser 0.49999999
if (x+y==0.5)
    console.log("ha redondejat lo de abans")

console.log()
console.log("Pruebas NaN")
console.log(0/0)    //NaN
console.log(x/0)    //Infinit
let z
console.log(z)  //z es undefined
console.log(x-z)    //Utilitzar un undefined en una op matematica, torna NaN

console.log()
console.log("Pruebas cadenas string")
let s1 ="Este es el primer string."
let s2="Segundo string."
console.log("Tamaño del primer string, el s1 es de: " + s1.length)
let s3 = s1 + s2
console.log("Tamaño del segundo string, el s2 es de: " + s2.length)
console.log("Tamaño del string concatenado, el s3 es de: " + s3.length)
console.log(s3) //Devuelve: Este es el primer string.Segundo string.

console.log()
console.log("Prueba bucle con resultado inesperado de tipificacion debil")
let variable10      //Como es undefined, va a fallar el bucle i devolvera NaN
console.log(variable10)
for (let counter = 1; counter <10; counter++)
    variable10 = variable10 + counter
    console.log(variable10)

console.log()
console.log("Pruebas coersion")
if("5">3)
    console.log("cadena 5 mayor que 3")
    else console.log("NOOO cadena 5 mayor que 3")

if("6"==6)
    console.log("cadena 6 es igual a 6")
    else console.log("NOOO cadena 6 es igual a 6")

if("user" == false)
    console.log("cadena user es igual a false")
    else console.log("la cadena user es igual a true")

if("" == false)
    console.log("cadena vacia es igual a false")
    else console.log("la cadena vacia es igual a true")

console.log()
console.log("Averiguar si una variable indefinida es vertadera o falsa")
let variableIndefinida
console.log(variableIndefinida)
if(variableIndefinida)
    console.log("La variable indefinida es vertadera")
    else console.log("la variable indefinida es falsa")

console.log()
console.log("Averiguar si una variable NaN es vertadera o falsa")
let variableNaN = 0/0
console.log(variableNaN)
if(variableNaN)
    console.log("La variable NaN es vertadera")
    else console.log("la variable NaN es falsa")

console.log()
console.log("Comparar valor de una variable amb undefined")
if (x == variableIndefinida)
    console.log("comparacio correcta")
    else console.log("comparacio falsa")