import { configureStore } from "@reduxjs/toolkit";
import stockSlice from "./stockSlice";

export const store = configureStore({
  reducer: {
    stock: stockSlice,
  },
});
