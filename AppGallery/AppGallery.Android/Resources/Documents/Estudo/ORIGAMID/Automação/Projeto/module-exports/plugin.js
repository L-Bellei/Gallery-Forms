function imc(peso, altura) {
  const imc = peso / (altura * altura);
  return imc.toFixed(2);
}

function quadrado(numero) {
  const quadrado = numero * numero;
  return quadrado.toFixed(2);
}

module.exports.imc = imc;
module.exports.quadrado = quadrado;