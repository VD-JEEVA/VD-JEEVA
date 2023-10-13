const express = require('express');
const mongoose = require('mongoose');

 

const app = express();

 

// Connect to MongoDB
mongoose.connect('mongodb://127.0.0.1:27017/database_skills', {
  useNewUrlParser: true,
  useUnifiedTopology: true
})
  .then(() => console.log('Connected to MongoDB'))
  .catch(err => console.error('Failed to connect to MongoDB', err));

 

// Define the schema for the technical skills
const technicalSkillsSchema = new mongoose.Schema({
  skill: String
});

 

const TechnicalSkill = mongoose.model('TechnicalSkill', technicalSkillsSchema);

 

// Endpoint to retrieve technical skills
app.get('/api/technical-skills', async (req, res) => {
  try {
    const skills = await TechnicalSkill.find({}, 'skill');
    const skillNames = skills.map(skill => skill.skill);
    res.json(skillNames);
  } catch (error) {
    res.status(500).json({ error: 'Internal Server Error' });
  }
});

 

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => console.log(`Server running on port ${PORT}`));
