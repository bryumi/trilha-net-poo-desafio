using DesafioPOO.Models;

Iphone meuSmartphoneApple = new Iphone("123456789", "iPhone 13", "5458", 32);
Nokia meuNokia = new Nokia("101213142", "Nokia 13", "222333", 64);

            // Chamando o método Ligar da classe Smartphone
meuSmartphoneApple.Ligar();
meuSmartphoneApple.InstalarAplicativo("DIO");
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Linkedin");

Console.ReadLine();