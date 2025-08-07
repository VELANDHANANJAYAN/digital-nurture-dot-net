import React from 'react';
import ListOfPlayers from './components/ListOfPlayers';
import IndianPlayers from './components/IndianPlayers';

function App() {
  const flag = true; // Toggle to false to show IndianPlayers

  return (
    <div className="App">
      <h1 style={{ textAlign: 'center' }}>🏏 Cricket App Dashboard</h1>

      {
        flag ? <ListOfPlayers /> : <IndianPlayers />
      }
    </div>
  );
}

export default App;
