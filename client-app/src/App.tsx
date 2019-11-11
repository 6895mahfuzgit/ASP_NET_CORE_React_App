import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, Icon } from 'semantic-ui-react'

class App extends Component {

 state={
   values:[]
 }

 componentDidMount(){

  axios.get('http://localhost:5000/api/values').then((response)=>{
    this.setState({
      values:response.data
    })
  });
}

//   this.setState({
//     values:[
//      {id:1,name:'Value 101'},
//      {id:2,name:'Value 102'},
//      {id:3,name:'Value 103'},
//      {id:4,name:'Value 104'},
//      {id:5,name:'Value 105'},
//     ]
//   })
//  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          
          <Header as='h2'>
    <Icon name='plug' />
    <Header.Content>Uptime Guarantee</Header.Content>
  </Header>
          <ul>{
             this.state.values.map((value:any)=>(
              <li key={value.id} >{value.name}</li>
             ))
           }  
           </ul>        
        </header>
      </div>
    );

  }
}


export default App;
