import express from 'express';
import helloRouter from './routers/helloRouter';

const app = express()
app.use(express.json())
app.use('/worlds', helloRouter);

export default app;


