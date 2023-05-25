const PROXY_CONFIG = [
  {
    context: ['/api/users/**', '/api/categories/**', '/api/books/**', '/api/rented/**', '/api/orders/**'],
    target: 'https://localhost:7249',
    secure: false,
  },
  {
    context: ['/api/auth/**'],
    target: 'https://localhost:7150',
    secure: false,
  },
];

module.exports = PROXY_CONFIG;
