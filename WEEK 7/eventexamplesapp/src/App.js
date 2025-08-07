// src/App.js
import React from 'react';
import Counter from './components/Counter';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  return (
    <div style={{ padding: '40px' }}>
      <h1 style={{ textAlign: 'center' }}>🧪 Event Handling in React</h1>
      <Counter />
      <CurrencyConvertor />
    </div>
  );
}

export default App;
