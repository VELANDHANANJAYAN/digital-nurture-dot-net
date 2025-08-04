import React from 'react';
import CohortDetails from './components/CohortDetails';
import './App.css'; // Optional if you're styling in App.css

function App() {
  return (
    <div className="App">
      <h1 style={{ textAlign: 'center' }}>Cohort Dashboard</h1>

      {/* Flex container to center the cohort boxes */}
      <div className="cohort-container">
        <CohortDetails
          name="React Bootcamp"
          status="Ongoing"
          startDate="2025-07-01"
          endDate="2025-09-01"
        />
        <CohortDetails
          name="Java Sprint"
          status="Completed"
          startDate="2025-05-01"
          endDate="2025-07-01"
        />
      </div>
    </div>
  );
}

export default App;
