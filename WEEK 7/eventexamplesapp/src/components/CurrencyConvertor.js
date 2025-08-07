// src/components/CurrencyConvertor.js
import React, { Component } from 'react';

class CurrencyConvertor extends Component {
  constructor() {
    super();
    this.state = {
      rupees: '',
      euro: null
    };

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(e) {
    this.setState({ rupees: e.target.value });
  }

  handleSubmit(e) {
    e.preventDefault(); // prevent page refresh
    const rupeesValue = parseFloat(this.state.rupees);
    if (!isNaN(rupeesValue)) {
      const euroValue = (rupeesValue / 90).toFixed(2); // Example rate: 1 Euro = 90 INR
      this.setState({ euro: euroValue });
    } else {
      alert('Please enter a valid number');
    }
  }

  render() {
    return (
      <div style={{ border: '1px solid gray', padding: '20px' }}>
        <h2>Currency Convertor</h2>
        <form onSubmit={this.handleSubmit}>
          <label>Enter Rupees:</label>
          <input
            type="text"
            value={this.state.rupees}
            onChange={this.handleChange}
            style={{ marginLeft: '10px' }}
          />
          <button type="submit" style={{ marginLeft: '10px' }}>
            Convert
          </button>
        </form>

        {this.state.euro !== null && (
          <p>Converted Euro: €{this.state.euro}</p>
        )}
      </div>
    );
  }
}

export default CurrencyConvertor;
