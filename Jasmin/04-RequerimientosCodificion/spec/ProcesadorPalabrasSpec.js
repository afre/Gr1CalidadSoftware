//Describir
describe("Procesador de palabras dado una frase", function () {
  it("debe eliminar los espacios en blanco", function () {
    expect(limpiezaEspacios("calidad de software")).toEqual("calidaddesoftware")
  });

  it("debe eliminar las vocales", function () {
    expect(limpiezaVocales("calidad de software")).toEqual("cldd d sftwar")
  });

  it("debe eliminar todas las consonantes", function () {
    expect(limpiezaConsonantes("calidad de software")).toEqual("ia e oae")
  });
})
