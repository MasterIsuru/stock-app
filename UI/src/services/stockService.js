import { axiosClient } from "./client";
import {
  TICKERS,
  PRICE_SOURCES,
  PRICE_SOURCES_TICKERS,
} from "./client/endpoints";

const getPriceSources = async (): Promise => {
  try {
    const response = await axiosClient.get(PRICE_SOURCES);
    return response?.data;
  } catch (e) {
    return Promise.reject(e);
  }
};

const getTickers = async (priceSourceId): Promise => {
  try {
    const response = await axiosClient.get(`${TICKERS}/${priceSourceId}`);
    return response?.data;
  } catch (e) {
    return Promise.reject(e);
  }
};

const getStockValues = async (priceSourceId, tickerId): Promise => {
  try {
    const response = await axiosClient.get(
      `${PRICE_SOURCES_TICKERS}/${priceSourceId}/${tickerId}`
    );
    return response?.data;
  } catch (e) {
    return Promise.reject(e);
  }
};

const StockService = {
  getTickers,
  getStockValues,
  getPriceSources,
};

export { StockService };
