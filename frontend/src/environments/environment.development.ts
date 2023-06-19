//ng serve --configuration=production
//Contém configurações específicas para o ambiente de desenvolvimento, como URLs de API, chaves de API, configurações de desenvolvimento do servidor, etc.
//Esse arquivo será usado quando você estiver desenvolvendo localmente e executando o aplicativo em um servidor local para fins de desenvolvimento.
import { provideServerRendering } from "@angular/platform-server";
export const environment = {
    production: false,
    prjectName: 'LABDEPS-DEV',
    text:'Ambiente de desenvolvimento',
    apiBaseUrl: 'http://sua-api.com',
    apiKey: 'sua-chave-de-api',
};
