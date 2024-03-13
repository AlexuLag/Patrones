using Adapter;

IAve pajaro = new Pajaro();

// Adaptar el objeto pájaro a un objeto pato
IPato pato = new PatoAdapter(pajaro);

// Usar el objeto pato
pato.Volar();
pato.Nadar();