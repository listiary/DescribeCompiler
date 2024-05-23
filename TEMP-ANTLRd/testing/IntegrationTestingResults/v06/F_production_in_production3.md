========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    water,
	fiber ->

        what,
        not;

	somth else;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'macronutrients ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n\n    water')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression_list
│   │       ├── expression
│   │       │   ├── item
│   │       │   │   └── text_chunk
│   │       │   │       └── T(DATA|'\n\tfiber ')
│   │       │   ├── producer
│   │       │   │   ├── T(HYPHEN|'-')
│   │       │   │   └── T(RIGHT_ARROW|'>')
│   │       │   ├── item_or_expression_list
│   │       │   │   ├── item
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(DATA|'\n\n        what')
│   │       │   │   ├── T(SEPARATOR|',')
│   │       │   │   └── item_or_expression
│   │       │   │       └── item
│   │       │   │           └── text_chunk
│   │       │   │               └── T(DATA|'\n        not')
│   │       │   └── T(TERMINATOR|';')
│   │       └── item_or_expression
│   │           └── item
│   │               └── text_chunk
│   │                   └── T(DATA|'\n\n\tsomth else')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')