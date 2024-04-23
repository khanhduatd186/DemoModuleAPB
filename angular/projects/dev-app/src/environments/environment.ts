import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'DemoModule',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44311/',
    redirectUri: baseUrl,
    clientId: 'DemoModule_App',
    responseType: 'code',
    scope: 'offline_access DemoModule',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44311',
      rootNamespace: 'DemoModule',
    },
    DemoModule: {
      url: 'https://localhost:44384',
      rootNamespace: 'DemoModule',
    },
  },
} as Environment;
