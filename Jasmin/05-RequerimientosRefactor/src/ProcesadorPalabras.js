function limpiezaEspacios(frase) {
  return frase.replace(/\ /g, "");
}

function limpiezaVocales(frase) {
  return frase.replace(/a|e|i|o|u/g, "");
}

function limpiezaConsonantes(frase) {
  return frase.replace(/[^a|e|i|o|u|\ ]/g, "");;
}
