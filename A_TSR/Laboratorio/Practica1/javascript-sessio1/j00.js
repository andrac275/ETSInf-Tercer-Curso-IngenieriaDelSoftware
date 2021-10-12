
//Uso de funciones, objetos, cláusula this y función bind().

console.log("\n");

function g(){return this.valor;}

var obj01={ valor:-5*2,
	      fun:function(){
				  var gg=g.bind(this);
				  return gg;
			   }
			   //La definicio de la linea 9 i la de la 14 i la 15 son equivalents
			//fun:function(){return g.bind(this)}	
			//return function(){return obj01.valor} 
	    }
	    
console.log("obj01.valor:  ",obj01.valor);
console.log("obj01.fun()():  ",obj01.fun()());	//El1r parentesi es per obtindre la funcio i el segon per possar en marxa la funcio

console.log("__________________________________________________________\n");

fx1=obj01.fun();
console.log("fx1():  ",fx1());

var obj02={ valor:"fun no me referencia",
	        fun:fx1, 	//function(){return function(){return obj01.valor}}
	        fan:g		//function(){return this.valor}
	      }
	      
console.log("obj02.valor:  ",obj02.valor);	    
console.log("obj02.fun():  ",obj02.fun());
console.log("obj02.fan():  ",obj02.fan());

console.log("__________________________________________________________\n");

obj01.valor="nuevo valor";
console.log("obj01.valor:  ",obj01.valor);
console.log("obj02.fun():  ",obj02.fun());
console.log("obj02.fan():  ",obj02.fan());
