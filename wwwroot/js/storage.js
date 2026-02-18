export function saveFormState(key, state) {
    try {
        sessionStorage.setItem(key, JSON.stringify(state));
        console.log('Form state saved to sessionStorage:', key, state);
        return true;
    } catch (error) {
        console.error('Error saving to sessionStorage:', error);
        return false;
    }
}

export function loadFormState(key) {
    try {
        const state = sessionStorage.getItem(key);
        console.log('Form state loaded from sessionStorage:', key, state);
        // Return the JSON string directly, not parsed
        return state;
    } catch (error) {
        console.error('Error loading from sessionStorage:', error);
        return null;
    }
}

export function clearFormState(key) {
    try {
        sessionStorage.removeItem(key);
        console.log('Form state cleared from sessionStorage:', key);
        return true;
    } catch (error) {
        console.error('Error clearing sessionStorage:', error);
        return false;
    }
}
