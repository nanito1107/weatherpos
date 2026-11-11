# WeatherPOS

Puente entre OpenWeatherMap y el POS Interface de Avigilon ACC. Consulta el
clima de una ciudad y lo emite como texto plano por un servidor TCP (puerto
10000 por defecto); el ACC lo consume como si fuera una caja registradora y lo
superpone al video. Cada mensaje va enmarcado entre `!!` y `##`.

WinForms sobre .NET Framework 4.5. Codigo heredado de un demo de Avigilon
(empezo como WeatherUndergroundPOS y migro a OpenWeatherMap; `wuAPI.cs` es el
fosil de la primera epoca).

## Configuracion

Todo se configura desde la propia ventana: API key de OpenWeatherMap, ciudad,
pais, puerto TCP e intervalo. Se guarda con `Settings.Save()` en el
`user.config` del perfil de Windows -- **la clave nunca vive en este
repositorio**, y asi debe seguir.

## Estado y deudas conocidas (revision 2026-08-04)

- El trabajo de red corre EN EL HILO DE LA INTERFAZ: la ventana se congela
  mientras consulta el clima. Es la causa de los cuelgues aparentes.
- `WebRequest` sobre HTTP sin cifrar.
- Al desconectarse el cliente ACC se detiene el servidor entero en vez de
  seguir esperando la reconexion.
- Compila solo en Windows (.NET Framework + WinForms). El sandbox del agente
  (.NET 10 en Linux) no puede construir la solucion; si puede trabajar las
  clases sueltas. La modernizacion a .NET 8 quedo planteada como proyecto
  aparte.
