import React from "react";
import { render } from "@testing-library/react";

import App from "./index";

import { Provider } from "react-redux";
import configureStore from "redux-mock-store";

describe("renders stock", () => {
  const initialState = {
    stock: { tickerData: null, stockTableData: null, priceSourceData: null },
  };
  const mockStore = configureStore();
  let store;

  test('shows price source', () => {
    store = mockStore(initialState);
    const { getByText } = render(
      <Provider store={store}>
        <App />
      </Provider>
    );
    expect(getByText("Price Source:")).not.toBeNull();
  });

  test('shows ticker', () => {
    store = mockStore(initialState);
    const { getByText } = render(
      <Provider store={store}>
        <App />
      </Provider>
    );
    expect(getByText("Ticker:")).not.toBeNull();
  });

  test('shows no data found', () => {
    store = mockStore(initialState);
    const { getByText } = render(
      <Provider store={store}>
        <App />
      </Provider>
    );
    expect(getByText("No data found")).not.toBeNull();
  });
});
