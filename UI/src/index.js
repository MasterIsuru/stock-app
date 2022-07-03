import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import { ToastContainer } from "react-toastify";

import Routes from "./routes";
import { store } from "./redux/reducers/rootReducer";

import "react-toastify/dist/ReactToastify.css";
import "./index.css";

export const ReactStrictMode = (
  <Provider store={store}>
    <ToastContainer />
    <Routes />
  </Provider>
);

export const rootElement = document.getElementById("root");

ReactDOM.render(ReactStrictMode, rootElement);
