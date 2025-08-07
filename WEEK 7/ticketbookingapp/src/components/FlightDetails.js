import React from 'react';

const FlightDetails = () => {
  return (
    <div style={{ border: '1px solid gray', padding: '20px', marginTop: '20px' }}>
      <h3>✈️ Flight Details</h3>
      <ul>
        <li>Flight: Indigo 6E123 | From: Chennai To: Mumbai | Time: 10:30 AM</li>
        <li>Flight: Air India AI455 | From: Delhi To: Bangalore | Time: 2:00 PM</li>
      </ul>
    </div>
  );
};

export default FlightDetails;
