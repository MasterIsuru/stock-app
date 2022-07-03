import { createSlice } from "@reduxjs/toolkit";

const initialState = {
  tickerData: null,
  stockTableData: null,
  priceSourceData: null,
};

export const stockSlice = createSlice({
  name: "stock",
  initialState,
  reducers: {
    setTickerData: (state, action) => {
      state.tickerData = action.payload;
    },
    setStockTableData: (state, action) => {
      state.stockTableData = action.payload;
    },
    setPriceSourceData: (state, action) => {
      state.priceSourceData = action.payload;
    },
  },
});

export const { setTickerData, setStockTableData, setPriceSourceData } =
  stockSlice.actions;

export default stockSlice.reducer;
