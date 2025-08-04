import React from 'react';
import CalculateScore from './components/CalculateScore';
import './Stylesheets/mystyle.css'; // make sure this is imported

function App() {
  return (
    <div className="App">
      <h1 className="portal-title">Student Management Portal</h1>
      <CalculateScore />
    </div>
  );
}

export default App;
