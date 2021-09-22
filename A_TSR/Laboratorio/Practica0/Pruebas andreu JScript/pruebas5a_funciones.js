function multiplicar(a , b){
    return a * b;
}

let resultado = multiplicar(50, 2);
console.log(resultado)

console.log()

let person ={ name:"Andreu",
                age:30,
                address: {
                    city:"Valencia",
                    street:"BlascoIbañez",
                    number:50
                }
            }
/*Devuelve undefined porque la funcion no utiliza la instruccion return */
function sinReturn(person){
    console.log("Hola " + person)
}
console.log(sinReturn("Andreu"))

console.log()

//Limite de los parametros.
function add(x,y,z){
    return x+y+z
}
console.log(add(1,2,3)) //6
console.log(add(1,2))   //NaN Com te menys arguments, rellena amb undefineds
console.log(add(null))  //NaN Com te menys arguments, rellena amb undefineds. Ne possaria 3.
console.log(add(1,2,3,4,5)) //6 Suma els tres primers, ignora la resta

console.log()

//Parametros con valor por omision
function add2(x=0,y=0,z=0){
    return x+y+z
}
console.log(add2(1,2,3)) //6
console.log(add2(1,2))   //3. Rellena la z amb un 0.
console.log(add2(null))  //0. Rellena x,y,z amb zeros
console.log(add2(1,2,3,4,5)) //6 Suma els tres primers, ignora la resta

console.log()

//Funciones con numero desconocido de argumentos. Usan el parametro '...'
function add3(x=0,y=0,...others){
    let sum = 0
    if(others.length > 0){
        for(let i = 0; i<others.length;i++){
            sum += others[i];
        }
    }
    return x + y + sum
}
console.log(add3(5,6,7,8,9))

console.log(add3({prop1:12},2,3))

console.log()

//Paso por valor y paso por referencia
function changeColour(car, newColour){
    return car.colour=newColour
}
function changeCar(car){
   car={brand:"Ferrari",colour:"Red"}
}
let myCar={brand:"Peugeot",colour:"Grey"}
console.log(myCar)
console.log(changeColour(myCar,"Blue"))
changeCar(myCar)
console.log(myCar)

console.log()

//60 de 97
function square(x){return x *x}
let a =square
let b = a(3)
let c = a

console.log(a)
console.log(b)
console.log(c)