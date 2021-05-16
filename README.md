# KitInicialUno

Este es un Kit de inicio de un sistema de manejo de contenido (páginas web) construida sobre la plataforma Umbraco. 

*** Acceso
email : admin@example.com password: 123456pass

*** Terminología
La sección administrativa, a la que en Ingles le llaman (backoffice = detrás de la oficina), aquí utilizaré la expresión "la oficina".

*** Tema
Contiene un tema defacto con colores definidos en "Tipos de Datos", "Personalizado", "Colores" y estilizado en la Hoja de estilo "estilo.css". Estos colores funcionan de la siguiente manera:
- La lista de colores definen el color de fondo y automáticamente (mediante la hoja de estilo) cambian el color del texto para generar el contraste necesario para poder ser legible. 
- Afectan el fondo de la sección de navegación, el pie página y los puedes modificar en Para llegar aquí, vas a "Ajustes", "Estilo menú" para cambiar el color de fondo del menú, y "Estilo de pie de pagina", para cambiar el fondo del pie de página. 
- En los módulos de contenido, los colores de fondo se los puede cambiar en los ajustes de cada módulo. 

*** Cambiar colores y estilo
Los colores y estilo están ligados el uno al otro y cualquier cambio puede romper la armonía del estilo. Entonces, si cambias los colores o adhieres otros, en la sección descrita arriba, deberás cambiar o adherir la hoja de estilo de la siguiente manera:
-Cambias el color y tomas nota de número generado por la propiedad, por ejemplo "#576490" y elijes un color que vaya a contrastar suficientemente y tomas nota de esto también, para este ejemplo usamos #d1d2f9.
- En la figura de abajo verás el color de fondo del ejemplo en el punto anterior y modificas o adhieres un estilo a la hoja de estilo. Toma nota de que la clase ".mp576490" está compuesta del color de fondo que elegiste, solo que cambias el sufijo "#" por "mp" y te resultará ".mp576490". 

"
.mp576490 {
    background: #576490;
    color: #d1d2f9;
}
"
*** Recaptcha
Este kit tiene la capacidad de recibir emails vía el Módulo de Formulario de contacto, pero para que funcione se necesita las llaves de Re-Captcha que los puedes obtener en google: https://www.google.com/recaptcha/about/

Una vez obtenidas las llaves, las pegas en la sección de ajustes
