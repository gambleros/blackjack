/* Okay let's render it*/
// var App=require('./all-components');
// var React=require('react');
import React, { Component } from 'react';
import App from './all-components';

React.render(
    <App/>,
    document.getElementById('app-container')
);