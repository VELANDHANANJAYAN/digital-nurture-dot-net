import React from 'react';

function App() {
  const heading = <h1 style={{ textAlign: 'center' }}>🏢 Office Space Rental Listings</h1>;

  const imageUrl = "Screenshot 2025-08-07 182333.png";

  const singleOffice = {
    name: "Alpha Business Center",
    rent: 55000,
    address: "123 MG Road, Chennai"
  };

  const officeList = [
    {
      name: "Beta Hub",
      rent: 72000,
      address: "456 Anna Salai, Chennai"
    },
    {
      name: "Gamma Towers",
      rent: 58000,
      address: "789 OMR, Chennai"
    },
    {
      name: "Delta Point",
      rent: 82000,
      address: "101 T Nagar, Chennai"
    }
  ];

  const renderOffice = (office, index) => {
    const rentStyle = {
      color: office.rent < 60000 ? 'red' : 'green',
      fontWeight: 'bold'
    };

    return (
      <div key={index} style={{ border: '1px solid gray', padding: '10px', marginBottom: '15px' }}>
        <h2>{office.name}</h2>
        <p><strong>Address:</strong> {office.address}</p>
        <p><strong>Rent:</strong> <span style={rentStyle}>₹{office.rent}</span></p>
      </div>
    );
  };

  return (
    <div style={{ padding: '20px' }}>
      {heading}

      <div style={{ textAlign: 'center' }}>
        <img src={imageUrl} alt="Office Space" width="600" />
      </div>

      <div style={{ marginTop: '20px' }}>
        <h2>{singleOffice.name}</h2>
        <p><strong>Address:</strong> {singleOffice.address}</p>
        <p><strong>Rent:</strong> ₹{singleOffice.rent}</p>
      </div>

      {/* Render multiple office listings */}
      <div style={{ marginTop: '30px' }}>
        <h2>More Office Listings:</h2>
        {officeList.map(renderOffice)}
      </div>
    </div>
  );
}

export default App;
