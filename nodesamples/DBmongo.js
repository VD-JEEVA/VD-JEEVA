const { MongoClient } = require('mongodb');
const url = 'mongodb://127.0.0.1:27017';
const dbName = 'Library_management';    

async function connectAndQuery() {
    const client = new MongoClient(url, {
        useNewUrlParser: true,
        useUnifiedTopology: true,
    });
    
    try {
        await client.connect();
        console.log('Connected to MongoDB');
        
        const db = client.db(dbName);
        const collection = db.collection('Library_customer');
        
        const docs = await collection.find({}).toArray();
        console.log("Documents:", docs);
    } catch (error) {
        console.error('Error:', error);
    } finally {
        await client.close();
        console.log("DISCONNECTED FROM MONGODB");
    }
}

connectAndQuery();

