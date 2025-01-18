class Streetlight {
  
  constructor(brand, model, type, wattage, lifespan, ballast) {
    this.brand = brand;
    this.model = model
    this.type = type;
    this.wattage = wattage;
    this.lifespan = lifespan; //in years for the moment
    this.ballast = ballast;
  }
  
}

let MA90 = new Streetlight("Philips", "MA90", "SOX", 90, 5, "BSX90L");
