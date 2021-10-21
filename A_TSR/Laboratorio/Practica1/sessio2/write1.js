const fs = require('fs');
fs.writeFile('/tmp/f', 'contenido del nuevo fichero', 'utf8', 
  function (err) {
  if (err) {
    return console.log(err);
  }
  console.log('se ha completado la escritura');
})

fs.writeFile('~/W/TSR/Laboratorio/Practica1/sessio2/fitxer', 'contenido del nuevo fichero', 'utf8', 
  function (err) {
  if (err) {
    return console.log(err);
  }
  console.log('se ha completado la escritura');
})
