// src/components/Counter.js
import React, { Component } from 'react';

class Counter extends Component {
  constructor() {
    super();
    this.state = {
      count: 0
    };

    // Bind methods (using this)
    this.increment = this.increment.bind(this);
    this.sayHello = this.sayHello.bind(this);
    this.decrement = this.decrement.bind(this);
  }

  increment() {
    this.setState({ count: this.state.count + 1 });
    this.sayHello(); // calling multiple methods
  }

  sayHello() {
    alert('Hello! You clicked Increment.');
  }

  decrement() {
    this.setState({ count: this.state.count - 1 });
  }

  sayWelcome(message) {
    alert(message);
  }

  handleSyntheticEvent(e) {
    alert('I was clicked');
    console.log('Synthetic event object:', e);
  }

  render() {
    return (
      <div style={{ border: '1px solid gray', padding: '20px', marginBottom: '30px' }}>
        <h2>Counter</h2>
        <p>Count: {this.state.count}</p>

        <button onClick={this.increment}>Increment</button>{' '}
        <button onClick={this.decrement}>Decrement</button>{' '}
        <button onClick={() => this.sayWelcome('Welcome to the Event Demo')}>Say Welcome</button>{' '}
        <button onClick={(e) => this.handleSyntheticEvent(e)}>Synthetic Event (OnPress)</button>
      </div>
    );
  }
}

export default Counter;
