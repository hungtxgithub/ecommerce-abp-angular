import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'EcommerceAbpFramework',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44320/',
    redirectUri: baseUrl,
    clientId: 'EcommerceAbpFramework_App',
    responseType: 'code',
    scope: 'offline_access EcommerceAbpFramework',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44332',
      rootNamespace: 'EcommerceAbpFramework',
    },
  },
} as Environment;
