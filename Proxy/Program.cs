using Proxy;

ProxyServicio proxy = new ProxyServicio();

// El cliente interactúa con el proxy
Cliente cliente = new Cliente(proxy);
cliente.EjecutarServicio();